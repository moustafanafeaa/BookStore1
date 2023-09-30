// See https://aka.ms/new-console-template for more information
using BookStore1;

//var b8 = new book
//{
//    id = 8,
//    title = "book8",
//    price = 10,
//    quantity = 20
//};
using ( var context = new ApplicationDBContext() )
{
    #region add,select
    //var b1 = context.books.FirstOrDefault(x => x.id == 2);
    //foreach (var book in context.books)
    //    Console.WriteLine(book);
    //Console.WriteLine(b1);

    //context.books.Add(b8);
    //context.SaveChanges();
    #endregion
    #region update
    //var book7 = context.books.Single(x => x.id == 7);
    //book7.price += 20;
    //context.SaveChanges();
    //Console.WriteLine(book7);
    //Console.WriteLine(b8);
    #endregion
    #region delete 
    //var book = context.books.Single(x => x.id == 8);
    //context.books.Remove( book );
    //context.SaveChanges();

    #endregion

}