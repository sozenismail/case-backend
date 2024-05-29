Kullanılan Teknolojiler

Asp.net Core, MsSql, Entity Framework, Code First, SeriLog, FluentValidation
Angular 16 , Bootstrap 5

Projenin video kaydı aşağıdadır.
https://www.youtube.com/watch?v=4axXuy6AEbc

Projeyi ilk çalıştırıldığında seed data ekledim. Bu sebeple direkt olarak migrate işlemlerini yaparak veritabanını oluşturabilirsiniz.

Filtreleme olarak sadece Şehir filtrelemesi ve Fiyat filtrelemesi ekledim. Ekstra olarak bina tipleri(villa,arsa,daire) ve satılık kiralık durumları da eklenebilir.

Backend tarafında mimari olarak Onion Architecture kullanıldı.
Loglama için SeriLog kullanıldı.
Validation işlemleri için FluentValidation kullanıldı.

Frontend tarafını Angular ile geliştirdim. 
node modules oluşturma işlemlerinin ardından ng serve komutunu yazarak projeyi çalıştırabilirsiniz.
