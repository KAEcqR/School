using ClassLibrary;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void SearchingFound()
        {
            FileOperations plik = new FileOperations("tekst.txt");

            string text = "Test";
     
            var (result,count) = plik.SearchString(text);

            Assert.Equal(1, count);
        }

        [Fact]
        public void SearchingNotFound()
        {
            FileOperations plik = new FileOperations("tekst.txt");

            string text = "Niestnieje";

            var (result, count) = plik.SearchString(text);

            Assert.Equal(0, count);
        }

        [Fact]
        public void SearchingSensitive()
        {
            FileOperations plik = new FileOperations("tekst.txt");

            string text = "testowania";

            var (result, count) = plik.SearchStringSensitive(text);

            Assert.Equal(0, count);
        }
    }
}
