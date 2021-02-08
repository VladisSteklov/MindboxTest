use TestingInterview

/* Создание таблицы продуктов */

Create Table Products (
id int Primary Key not null,
name varchar(256) not null,
);

/* Создание таблицы категорий*/
Create Table Categories (
id int Primary Key not null,
name varchar(256) not null,
);

/* Создание связующей таблицы для реализации связи многие ко многим*/

Create Table Products_Categories (
ProductId int not null,
CategoryId int not null,
Primary Key(ProductId,CategoryId),
Foreign Key(ProductId) references Products(id),
Foreign Key(CategoryId) references Categories(id)
);

/*Добавление элементов в таблицы*/
insert into dbo.Categories(id, name) values (1,'Категория1');
insert into dbo.Categories(id, name) values (2,'Категория2');
insert into dbo.Categories(id, name) values (3,'Категория3');
insert into dbo.Categories(id, name) values (4,'Категория4');

insert into dbo.Products(id, name) values (1,'Продукт1');
insert into dbo.Products(id, name) values (2,'Продукт2');
insert into dbo.Products(id, name) values (3,'Продукт3');
insert into dbo.Products(id, name) values (4,'Продукт4');

/* У 4-го продукта нет категории - у категории будет выведен NULL*/
insert into dbo.Products_Categories(ProductId, CategoryId) values (1,3);
insert into dbo.Products_Categories(ProductId, CategoryId) values (2,2);
insert into dbo.Products_Categories(ProductId, CategoryId) values (3,1);
insert into dbo.Products_Categories(ProductId, CategoryId) values (3,2);
insert into dbo.Products_Categories(ProductId, CategoryId) values (2,3);
insert into dbo.Products_Categories(ProductId, CategoryId) values (3,4);
insert into dbo.Products_Categories(ProductId, CategoryId) values (3,3);

select * from dbo.Products;
select * from dbo.Categories;
select * from dbo.Products_Categories;

/*---------------------------------------------------------------------------ТРЕБУЕМЫЙ ЗАПРОС ---------------------------------------------------------*/
/* У 4-го продукта нет категории - у категории будет выведен NULL*/
select dbo.Products.name as 'Название продукта', dbo.Categories.name as 'Категория продукта' 
from dbo.Products left join dbo.Products_Categories on dbo.Products.id = dbo.Products_Categories.ProductId
left join dbo.Categories on dbo.Products_Categories.CategoryId = dbo.Categories.id;