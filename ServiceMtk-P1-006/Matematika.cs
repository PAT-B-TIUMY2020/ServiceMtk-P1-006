using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceMtk_P1_006
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Matematika : IMatematika
    {
        public int Bagi(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

                //secara Default
                //throw new Exception(ex.Message) //pesan error secara default
                //throw new FaultException("Pesan Salah"); //untuk meloloskan pesan error yang di kirim ke client

                MathFault mf = new MathFault();
                mf.Kode = "Input Yang Anda Masukkan Salah";
                mf.Pesan = "Masukkan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }
        

        public int Kali(int a, int b)
        {
            try
            {
                return a * b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                //secara Default
                //throw new Exception(ex.Message) //pesan error secara default
                //throw new FaultException("Pesan Salah"); //untuk meloloskan pesan error yang di kirim ke client

                MathFault mf = new MathFault();
                mf.Kode = "Input Yang Anda Masukkan Salah";
                mf.Pesan = "Masukkan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }

        public int Kurang(int a, int b)
        {
            try
            {
                return a - b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                //secara Default
                //throw new Exception(ex.Message) //pesan error secara default
                //throw new FaultException("Pesan Salah"); //untuk meloloskan pesan error yang di kirim ke client

                MathFault mf = new MathFault();
                mf.Kode = "Input Yang Anda Masukkan Salah";
                mf.Pesan = "Masukkan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }

        public int Tambah(int a, int b)
        {
            try
            {
                return a + b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                //secara Default
                //throw new Exception(ex.Message) //pesan error secara default
                //throw new FaultException("Pesan Salah"); //untuk meloloskan pesan error yang di kirim ke client

                MathFault mf = new MathFault();
                mf.Kode = "Input Yang Anda Masukkan Salah";
                mf.Pesan = "Masukkan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }

        public Koordinat TKoordinat(Koordinat a, Koordinat b)
        {
            try
            {
                Koordinat hasil = new Koordinat();
                hasil.X = a.X + b.X;
                hasil.Y = a.Y + b.Y;
                return hasil;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                //secara Default
                //throw new Exception(ex.Message) //pesan error secara default
                //throw new FaultException("Pesan Salah"); //untuk meloloskan pesan error yang di kirim ke client

                MathFault mf = new MathFault();
                mf.Kode = "Input Yang Anda Masukkan Salah";
                mf.Pesan = "Masukkan input yang benar";
                throw new FaultException<MathFault>(mf);
            }

        }
    }
}
//alfianhidayahh
