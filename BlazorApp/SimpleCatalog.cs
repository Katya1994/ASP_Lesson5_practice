namespace BlazorApp;

// public class MyCatalog: ICatalog
// {
//     public IList<Product> List { get; set; } = new List<Product>()
//     {
//         new Product("Стивен Кинг", 1500, "https://img4.labirint.ru/rc/2f7d48ee73c87a4d16e8385b1a0d413b/220x340/books69/683432/cover.jpg?1564173848"),
//         new Product("Борис Акунин", 1400, "https://img4.labirint.ru/rc/72e9df791abc65b7421717b99f880206/220x340/books76/754834/cover.jpg?1597847102"),
//         new Product("Михаил Булгаков", 999, "https://img4.labirint.ru/rc/be52f38894b280fb49d5c6c7ef390287/220x340/books25/244606/cover.jpg?1472463171")
//     };
// }
public class SimpleCatalog: ICatalog
{
    private IClock myDate;
    
    // private IList<Product> _products = new List<Product>()
    // {
    //     new Product("Книга Стивена Кинга", 1500, "https://img4.labirint.ru/rc/2f7d48ee73c87a4d16e8385b1a0d413b/220x340/books69/683432/cover.jpg?1564173848"),
    //     new Product("Книга Бориса Акунина", 1400, "https://img4.labirint.ru/rc/72e9df791abc65b7421717b99f880206/220x340/books76/754834/cover.jpg?1597847102"),
    //     new Product("Книга Михаила Булгакова", 999, "https://img4.labirint.ru/rc/be52f38894b280fb49d5c6c7ef390287/220x340/books25/244606/cover.jpg?1472463171")
    // };

    private IDictionary<Category, List<Product>> _products = new Dictionary<Category, List<Product>>()
    {
        {
            Category.Book,
            new List<Product>()
        {
            new Product("Книга Стивена Кинга", 1500, "https://img4.labirint.ru/rc/2f7d48ee73c87a4d16e8385b1a0d413b/220x340/books69/683432/cover.jpg?1564173848",
                "«Чужак» (англ. The Outsider) — детективный роман американского писателя Стивена Кинга. Первое издание вышло в США в 2018 году. Напрямую связано с другим произведением Стивена."),
            new Product("Книга Бориса Акунина", 1400, "https://img4.labirint.ru/rc/72e9df791abc65b7421717b99f880206/220x340/books76/754834/cover.jpg?1597847102",
                "Детективный роман Бориса Акунина, действие которого разворачивается на фоне грозных событий войны 1812 года, является художественным приложением к седьмому тому проекта «История Российского государства». " +
                "Такой пары сыщиков в истории криминального жанра, кажется, еще не было…"),
            new Product("Книга Михаила Булгакова", 999, "https://img4.labirint.ru/rc/be52f38894b280fb49d5c6c7ef390287/220x340/books25/244606/cover.jpg?1472463171",
                "Трудно назвать еще одного русского писателя, творчество которого было бы в такой же степени автобиографично, как у Михаила Булгакова - писателя сложной и горькой судьбы, пережившего потерю милой его " +
                "сердцу прежней России, преодолевшего страшный недуг морфинизма, художника, противостоявшего революционной бесовщине и до конца дней вовлеченного в трагический конфликт с деспотическим строем")
        }},
        {
            Category.Rocket,
            new List<Product>()
        {
            new Product("РН Falcon Heavy", 10000000000m, "https://mocah.org/mocahbig/65061-Falcon-HeavyFalcon-Heavy-HD-Wallpaper.jpg", 
                "Falcon Heavy - американская ракета-носитель (РН) сверхтяжёлого класса с возможностью повторного использования первой ступени и боковых ускорителей, спроектированная и произведённая компанией SpaceX, " +
                "является одной из крупнейших ракет-носителей в истории мирового космического ракетостроения"),
            new Product("Космический корабль БУРАН", 150000000m, "https://avatars.mds.yandex.net/get-zen_doc/3384412/pub_5ff49993fe4e686f6a3e9ea2_5ff499ded1a90641ca0dc690/scale_1200",
                " советский орбитальный корабль-ракетоплан многоразовой транспортной космической системы (МТКС), созданный в рамках программы Энергия — Буран.Первый и единственный космический полёт «Буран» совершил 15 ноября 1988 года в автоматическом режиме, " +
                "без экипажа на борту; больше его не запускали («Буран» был рассчитан на 100 полётов в космос). Ряд технических решений, полученных при создании «Бурана», был использован в российской и зарубежной ракетно-космической технике"),
            new Product("РН Протон", 9990000m, "https://upload.wikimedia.org/wikipedia/commons/thumb/1/14/Proton_Zvezda_crop.jpg/274px-Proton_Zvezda_crop.jpg",
            " ракета-носитель (РН) тяжёлого класса, предназначенная для выведения автоматических космических аппаратов на орбиту Земли и далее в космическое пространство. Способна выводить на геостационарную орбиту (ГСО) грузы до 3,3 т. " +
            "Разработана в 1961—1967 годах в подразделении ОКБ-23 (ныне ГКНПЦ имени М. В. Хруничева), являвшемся частью ОКБ-52 В. Н. Челомея.")
        }}   
    };


    private IDictionary<Category, List<Product>> _productsAtWeekend;
    
    public SimpleCatalog(IClock myDate)
    {
        this.myDate = myDate;
    }

    public IDictionary<Category, List<Product>> GetProductList()
    {
        //_productsAtWeekend = new Dictionary<Category, List<Product>>();
        
        /*var dateOfWeek = myDate.GetCurrentDate().DayOfWeek;
        if (dateOfWeek == DayOfWeek.Sunday || dateOfWeek == DayOfWeek.Saturday)
        {
            foreach (var item in _products)
            {
                _productsAtWeekend.Add(item.Key, new List<Product>());
                foreach (var list in _products.Values)
                {
                    foreach (var product in list)
                    {
                        _productsAtWeekend[item.Key].Add(new Product(product.Name, product.Price* 1.5m, product.Url));
                    }
                }
            }

            return _productsAtWeekend;
        }*/

        return _products;
    }
}