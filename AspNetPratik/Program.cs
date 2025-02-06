var builder = WebApplication.CreateBuilder(args);

// MVC desteðini ekleyelim
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles(); // wwwroot içindeki statik dosyalarý kullan
app.UseRouting();
app.UseAuthorization();

// Default MVC route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();




/*
                *** CONTROLLER ***
             

*    MVC mimarisinde kullanýcýdan gelen istekleri karþýlayan ve yöneten sýnýflardýr.
*    Ýþleyiþi yönetir, model-veri ile view arasýnda köprü görevi görür.



                *** ACTÝON ***
                

*   Controller içerisinde yer alan ve belirli isteklere yanýt veren metot.
*   Kullanýcý bir URL ye istek yaptýðý zaman ilgili Controller içindeki Action metodu çalýþýr
             
                *** MODEL ***
               


*   Uygulamanýn veri yapýsýný temsil eden sýnýflardýr.
*   Veri Tabaný ile Controller arasýnda köprü görevi görür



                *** VÝEW ***
                

*   Kullanýcýya gösterilecek kodlarýn içeriðini oluþturur.


                *** RAZOR ***
                

*   Dinamik HTML sayfalarý oluþturmak için kullanýlan þablondur.



                *** WWWROOT ***
                

*    Static dosyalarý barýndýran klasördür (resim, video, logo vb)


                *** BUÝLDER.BUÝD ***
              

*   WebAplication nesnesini oluþturur.


                *** APP.RUN ***

*   Uygulamayý baþlatýr.


 */
