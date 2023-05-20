# DBFirst Northwind OrderList
Bu uygulamada Database First yaklaþýmý kullanýlmýþtýr. Northwind database kullanýlarak bu databasedeki çalýþanlarýn Orderlarý listelemek ve bu orderlar üzerinde güncelleme, silme ve yeni order ekleme iþlemlerini yapmak için oluþturulmuþ bir uygulamadýr. Programýn çalýþmasý için Northwind SQL Server içinde database olarak bilgisayarýnýzda bulunmalýdýr. 

## Programýn Çalýþmasý

1. Program Form1 olan ana ekranda Northwindeki Employess ve Shippers listelerini ekrana getirir. Kullanýcý sipariþlerini görmek istediklerini bu listelerden seçer ve "Get Order List" butonuna basarak
seçilenlerin sipariþ listelerini ekrana getirir.
<div align="center">
	<img src="https://github.com/Enes-Kurt/EntityFramework-Examples-CSharp/blob/master/1-%20DBFirst%20Northwind%20OrderList/Images/Form1.png" alt="Form1" height="300">
</div>

2. Order List kýmsýndaki listeden bir sipariþ seçen kullanýcý isteðe baðlý olarak sipariþi silebilir, güncelleyebilir ve yeni sipariþ ekleyebilir. Ekleme ve güncelleme ayný form(Form2) üzerinden yapýlýr.  
Ekleme Ekraný  
<div align="center">
	<img src="https://github.com/Enes-Kurt/EntityFramework-Examples-CSharp/blob/master/1-%20DBFirst%20Northwind%20OrderList/Images/Form2Add.png" alt="Form1-Form2Add" height="300">
</div>  

Güncelleme Ekraný  
<div align="center">
	<img src="https://github.com/Enes-Kurt/EntityFramework-Examples-CSharp/blob/master/1-%20DBFirst%20Northwind%20OrderList/Images/Form2Update.png" alt="Form1-Form2Update" height="300">
</div>