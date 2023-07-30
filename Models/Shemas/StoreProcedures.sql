-- Select procs
Create Proc GetBrands
as
Begin
	Select * From production.brands
End
Go
Create Proc GetCategories
as
Begin
	Select * From production.categories
End
Go
Create Proc GetProducts
as
Begin
	Select
		p.product_id,
		p.product_name,
		b.brand_name,
		c.category_name,
		p.model_year,
		p.list_price
	From production.products as p
		Inner Join production.brands as b on b.brand_id = p.brand_id
		Inner join production.categories as c on c.category_id = p.category_id
End
Go
Create Proc GetProductById
(
	@id int
)
as
Begin
	Select * From production.products Where product_id = @id
End
Go


-- Create procs

Create Proc InsertProduct
(
	@product_name nvarchar(500),
	@brand_id int,
	@category_id int,
	@model_year int,
	@list_price decimal(10, 2)
)
as
Begin
	Insert Into production.products
	Values(@product_name, @brand_id, @category_id, @model_year, @list_price)
End
Go


-- Update procs

Create Proc UpdateProduct
(
	@product_id int,
	@product_name nvarchar(500),
	@brand_id int,
	@category_id int,
	@model_year int,
	@list_price decimal(10, 2)
)
as
Begin
	Update production.products
	Set
		product_name = @product_name, 
		brand_id = @brand_id, 
		category_id = @category_id, 
		model_year = @model_year, 
		list_price = @list_price
	Where
		product_id = @product_id
End
Go



-- Delete procs

Create Proc DeleteProductByID
(
	@id int
)
as
Begin
	Delete production.products
	Where
		product_id = @id
End
Go

