




using Task2;

var photoBook = new PhotoBook(16);
var bigPhotoBook = new BigPhotoBook(24);
var photoBookTest = new PhotoBookTest(64);

System.Console.WriteLine(photoBook.GetPhotoBook());
System.Console.WriteLine(bigPhotoBook.GetPhotoBook());
System.Console.WriteLine(photoBookTest.GetPhotoBook());