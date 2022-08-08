using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenge
{
    class Address
    {
        private string rt;
        private string rw;
        private string kelurahan;
        private string kecamatan;
        private string kabupaten;
        private string provinsi;
        private string catatan;
        private string jalan;

        public Address(string rt, string rw, string kelurahan, string kecamatan, string kabupaten, string provinsi, string catatan, string jalan)
        {
            this.rt = rt;
            this.rw = rw;
            this.kelurahan = kelurahan;
            this.kecamatan = kecamatan;
            this.kabupaten = kabupaten;
            this.provinsi = provinsi;
            this.catatan = catatan;
            this.jalan = jalan;
        }

        public string getRt()
        {
            return this.rt;
        }

        public string getRw()
        {
            return this.rw;
        }

        public string getKelurahan()
        {
            return this.kelurahan;
        }

        public string getKecamatan()
        {
            return this.kecamatan;
        }

        public string getKabupaten()
        {
            return this.kabupaten;
        }

        public string getProvinsi()
        {
            return this.provinsi;
        }

        public string getJalan()
        {
            return (this.jalan == null) ? "-" : this.jalan;
        }

        public string getCatatan()
        {
            return (this.catatan == null) ? "-" : this.catatan;
        }

        public void print()
        {
            Console.WriteLine($"RT. {this.getRt()}, RW. {this.getRw()}, KEL. {this.getKelurahan()}, KEC. {this.getKecamatan()}, KAB. {this.getKabupaten()}, PROV. {this.getProvinsi()},");
            Console.WriteLine($"JLN. {this.getJalan()}, Catatan: {this.getCatatan()}");
        }

        public class Builder
        {
            public Address address;

            public Builder(string rt, string rw, string kelurahan, string kecamatan, string kabupaten, string provinsi, string catatan, string jalan)
            {
                this.address = new Address(rt, rw, kelurahan, kecamatan, kabupaten, provinsi, jalan, catatan);
            }

            public Builder withStreet(string jalan)
            {
                this.address.jalan = jalan;
                return this;
            }

            public Builder withNote(string catatan)
            {
                this.address.catatan = catatan;
                return this;
            }


            public Address build()
            {
                return address;
            }
        }
    }
}