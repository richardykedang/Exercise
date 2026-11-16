using LeetCode._1.ArrayAndStrings;

Console.WriteLine("=== Coding Interview Practice ===");
Console.WriteLine("1. LeetCode");
Console.WriteLine("2. HackerRank");
Console.Write("Pilih platform: ");

switch (Console.ReadLine())
{
    case "1":
        Console.WriteLine("=== LeetCode ===");
        Console.WriteLine("1. Array and Strings");
        Console.WriteLine("2. Linked List");
        Console.WriteLine("3. Trees");
        Console.WriteLine("4. Graphs");
        Console.WriteLine("5. Dynamic Programming");
        Console.Write("Pilih kategori: ");
        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine("=== Array and Strings ===");
                Console.WriteLine("1. Merge String Alternately (PI1678)");
                Console.Write("Pilih soal: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        var mergeString = new PI1678_MergeString();
                        string word1 = "abc";
                        string word2 = "pqr";
                        string result = mergeString.MergeAlternately(word1, word2);
                        Console.WriteLine($"Hasil penggabungan: {result}");
                        break;
                    default:
                        Console.WriteLine("Soal tidak ditemukan.");
                        break;
                }
                break;
            default:
                Console.WriteLine("Kategori tidak ditemukan.");
                break;
        }
        break;
    case "2":
        Console.WriteLine("=== HackerRank ===");
        // Implementasi untuk HackerRank dapat ditambahkan di sini
        break;
    default:
        Console.WriteLine("Platform tidak ditemukan.");
        break;
}