using System;

namespace CodeChallenge
{
    class Program
    {

        static void Main(string[] args)
        {
            Nasabah nasabah = new Nasabah.Builder("Wahyu Aprilliandhika", 21113869, "-", "Medan", "-", 0)
            .withOffice("JLN. Candi Borubudur Medan")
            .withPhoneNumber("081234567865")
            .withSallary(10000000)
            .build();

            nasabah.print();

            Console.WriteLine();

            Address address = new Address.Builder("10", "03", "Tanjung sari", "Medan Selayang", "Kota Medan", "Sumatra Utara", "0", "0")
            .withStreet("Pasar 1 Gg.rezeki")
            .withNote("Warna putih")
            .build();
            Console.Write("Alamat: ");
            
            address.print();
        }
    }
}
