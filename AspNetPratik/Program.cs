var builder = WebApplication.CreateBuilder(args);

// MVC deste�ini ekleyelim
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles(); // wwwroot i�indeki statik dosyalar� kullan
app.UseRouting();
app.UseAuthorization();

// Default MVC route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();




/*
                *** CONTROLLER ***
             

*    MVC mimarisinde kullan�c�dan gelen istekleri kar��layan ve y�neten s�n�flard�r.
*    ��leyi�i y�netir, model-veri ile view aras�nda k�pr� g�revi g�r�r.



                *** ACT�ON ***
                

*   Controller i�erisinde yer alan ve belirli isteklere yan�t veren metot.
*   Kullan�c� bir URL ye istek yapt��� zaman ilgili Controller i�indeki Action metodu �al���r
             
                *** MODEL ***
               


*   Uygulaman�n veri yap�s�n� temsil eden s�n�flard�r.
*   Veri Taban� ile Controller aras�nda k�pr� g�revi g�r�r



                *** V�EW ***
                

*   Kullan�c�ya g�sterilecek kodlar�n i�eri�ini olu�turur.


                *** RAZOR ***
                

*   Dinamik HTML sayfalar� olu�turmak i�in kullan�lan �ablondur.



                *** WWWROOT ***
                

*    Static dosyalar� bar�nd�ran klas�rd�r (resim, video, logo vb)


                *** BU�LDER.BU�D ***
              

*   WebAplication nesnesini olu�turur.


                *** APP.RUN ***

*   Uygulamay� ba�lat�r.


 */
