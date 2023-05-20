# DBFirst Northwind OrderList
Bu uygulamada Database First yakla��m� kullan�lm��t�r. Northwind database kullan�larak bu databasedeki �al��anlar�n Orderlar� listelemek ve bu orderlar �zerinde g�ncelleme, silme ve yeni order ekleme i�lemlerini yapmak i�in olu�turulmu� bir uygulamad�r. Program�n �al��mas� i�in Northwind SQL Server i�inde database olarak bilgisayar�n�zda bulunmal�d�r. 

## Program�n �al��mas�

1. Program Form1 olan ana ekranda Northwindeki Employess ve Shippers listelerini ekrana getirir. Kullan�c� sipari�lerini g�rmek istediklerini bu listelerden se�er ve "Get Order List" butonuna basarak
se�ilenlerin sipari� listelerini ekrana getirir.
<div align="center">
	<img src="https://github.com/Enes-Kurt/EntityFramework-Examples-CSharp/blob/master/1-%20DBFirst%20Northwind%20OrderList/Images/Form1.png" alt="Form1" height="300">
</div>

2. Order List k�ms�ndaki listeden bir sipari� se�en kullan�c� iste�e ba�l� olarak sipari�i silebilir, g�ncelleyebilir ve yeni sipari� ekleyebilir. Ekleme ve g�ncelleme ayn� form(Form2) �zerinden yap�l�r.  
Ekleme Ekran�  
<div align="center">
	<img src="https://github.com/Enes-Kurt/EntityFramework-Examples-CSharp/blob/master/1-%20DBFirst%20Northwind%20OrderList/Images/Form2Add.png" alt="Form1-Form2Add" height="300">
</div>  

G�ncelleme Ekran�  
<div align="center">
	<img src="https://github.com/Enes-Kurt/EntityFramework-Examples-CSharp/blob/master/1-%20DBFirst%20Northwind%20OrderList/Images/Form2Update.png" alt="Form1-Form2Update" height="300">
</div>