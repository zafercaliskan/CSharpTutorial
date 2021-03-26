--ANSII
select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City = 'Berlin'

--case insensitive
sElEcT * from Products where categoryId=1 or categoryId=3 --id 1 yada 3 olanlar gelsin

select * from Products where categoryId=1 and UnitPrice>10 --10'dan büyük olanlar. Ve ..
select * from Products where categoryId=1 and UnitPrice>=10 --10'a eşit veya büyük olanlar. Ve ..
select * from Products where categoryId=1 and UnitPrice<>10 --10'dan farklı olanları getir demek. Ve.. 

select * from Products where categoryId=1 order by UnitPrice desc --descending Azalan sıralama
select * from Products where CategoryID=2 order by UnitsInStock --ascending Artan sıralama
select * from Products where CategoryID=2 order by UnitsInStock asc --ascending vermesekde olur.
select count(*) Adet from Products

--içinde 10 taneden az ürün çeşidi olan kategorileri ver demektir alt sorgu.
select categoryID,count(*) from products group by CategoryID having count(*)<10 
--having ifadesi kümülatfi sorguya yazılır. count sayısı, avg ortalaması demek. sum toplamı demek.

select categoryID,count(*) from products where UnitPrice>20 group by CategoryID having count(*)<10  --önce herzaman where çalışır.
--Birim fiyatı 20'den fazla olan ürünleri, categoryid'ye göre grupla. 
--Onlardan da sayısı her bir grupta 10'dan az onları gruplar. Having kümülatiflere uygulanır.


select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName from Products 
inner join Categories on Products.ProductID=Categories.CategoryID where Products.UnitPrice>10

--DTO Data Transformation object
select * from Products p inner join [Order Details] od
on p.ProductID=od.ProductID
inner join Orders o
on o.OrderID=od.OrderID

select * from Customers c left join Orders o
on c.CustomerID=o.CustomerID
where o.CustomerID is null --solda olup sağda olmayanlarıda getir demek. Ürünler tablosunda var ama hiç satışı yok mesela.

select * from Customers c inner join Orders o on c.CustomerID=o.CustomerID
--830 kayıt

select * from Customers c left join Orders o on c.CustomerID=o.CustomerID
--832 kayıt solda olup müşterilerde olup siparişte olmayanları da getir demek.
--Hem inner join alanları hemde siparişde olmayanları da getir demek.

--Örnek soru: Sistemimize kayıt olmuş ama ürün almamış kişileri getir ben ona kampanya uygulayacağım. Çünkü aktif müşteri haline 
--getirmek istiyorum. 
select * from Customers c left join Orders o on c.CustomerID=o.CustomerID
where o.CustomerID is null

--left veya right join aynıdır. sağda veya solada olanları dahil etmek içindir. Genellikle left join kullanılır. 
--Fakat yazıma göre olduğu için bazen sağda kalabilir o yüzden right joinde kullanmak gerekebilir.