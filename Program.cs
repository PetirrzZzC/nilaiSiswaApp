int nilai;
string nama;

Console.WriteLine("Aplikasi Nilai Siswa");

Console.WriteLine("Masukkan Nama : ");
nama = Console.ReadLine();

Console.WriteLine("Masukkan Nilai : ");
nilai = int.Parse(Console.ReadLine());

if (nilai >= 75)
    Console.WriteLine("Selamat, Anda Lulus!");
else
    Console.WriteLine("Maaf, Anda Belum Lulus");