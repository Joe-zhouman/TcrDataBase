// See https://aka.ms/new-console-template for more information
using model;
public class UnitTest {
    static void Main(String[] args) {
        foreach (var pair in Constant.DATABASE_COL_NAME) {
            Console.WriteLine($"{pair.Value} : {pair.Value}");
        }
    }
}
