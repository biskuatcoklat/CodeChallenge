using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenge
{
    class Nasabah
    {
        public string nama;
        public long nik;
        public string alamatRumah;
        public string alamatKantor;
        public string nomorHp;
        public long gaji;

        public Nasabah(string nama, long nik, string alamatRumah, string alamatKantor, string nomorHp, long gaji)
        {
            this.nama = nama;
            this.nik = nik;
            this.alamatRumah = alamatRumah;
            this.alamatRumah = alamatKantor;
            this.nomorHp = nomorHp;
            this.gaji = gaji;
        }

        public string getNama()
        {
            return this.nama;
        }

        public long getNik()
        {
            return this.nik;
        }

        public string getAlamatRumah()
        {
            return this.alamatRumah;
        }

        public string getAlamatKantor()
        {
            return (this.alamatKantor == null) ? "-" : this.alamatKantor;
        }

        public string getNomorHp()
        {
            return (this.nomorHp == null) ? "-" : this.nomorHp;
        }

        public long getGaji()
        {
            return this.gaji;
        }

        public void print()
        {
            Console.WriteLine($"Nama : {this.getNama()}, NIK : {this.getNik()}, Alamat Rumah: {this.getAlamatRumah()}");
            Console.WriteLine($"Alamat Kantor : {this.getAlamatKantor()}, Nomor HP: {this.getNomorHp()}, Gaji: {this.getGaji()}");
        }

        public class Builder
        {
            public Nasabah nasabah;
            
            public Builder (string nama, long nik, string alamatRumah, string alamatKantor, string nomorHp, long gaji)
            {
                this.nasabah = new Nasabah (nama, nik, alamatRumah, alamatKantor, nomorHp, gaji);
            }

            public Builder withOffice(string alamatKantor)
            {
                this.nasabah.alamatKantor = alamatKantor;
                return this;
            }

            public Builder withPhoneNumber(string nomorHp)
            {
                this.nasabah.nomorHp = nomorHp;
                return this;
            }

            public Builder withSallary(long gaji)
            {
                this.nasabah.gaji = gaji;
                return this;
            }

            public Nasabah build()
            {
                return nasabah;
            }
        }
    }
}
