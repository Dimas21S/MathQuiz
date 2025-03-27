# DeQuiz - Aplikasi Kuis Matematika

## Deskripsi
DeQuiz adalah aplikasi kuis matematika berbasis Windows Forms menggunakan C#. Aplikasi ini memberikan soal matematika sederhana dengan operasi penjumlahan, pengurangan, perkalian, dan pembagian. Pengguna akan mendapatkan poin setiap kali menjawab dengan benar, dan permainan akan berhenti setelah waktu habis.

## Fitur
- Timer berjalan selama 5 menit.
- Operasi matematika yang diacak (+, -, x, /).
- Poin bertambah jika jawaban benar.
- Soal baru muncul setiap kali pengguna menjawab.
- Permainan berhenti secara otomatis saat waktu habis.

## Teknologi yang Digunakan
- C# dengan Windows Forms
- Visual Studio

## Cara Menggunakan
1. **Jalankan aplikasi** dengan membuka proyek di Visual Studio dan menjalankannya.
2. **Klik tombol "Start"** untuk memulai kuis.
3. **Klik tombol stop** untuk menghentikan permainan sementara.
4. **Jawab soal yang muncul** dengan mengetikkan jawaban di `textBoxHasil` dan tekan "Enter".
5. **Poin akan bertambah** jika jawaban benar.
6. **Kuis berakhir** setelah 5 menit

## Struktur Kode
- `Form1.cs`: File utama yang menangani logika permainan.
- `GenerateQuestion()`: Fungsi untuk membuat soal matematika baru.
- `buttonEnter_Click()`: Memproses jawaban pengguna.
- `timer1_Tick()`: Menghitung waktu permainan.
- `buttonStart_Click()`: Memulai kuis.
- `buttonStop_Click()`: Menghentikan kuis.

## Instalasi dan Konfigurasi
1. Pastikan **Visual Studio** sudah terinstal.
2. Buka proyek di Visual Studio.
3. Jalankan aplikasi dengan menekan tombol running.

## Catatan Tambahan
- Aplikasi ini menggunakan `Random` untuk mengacak angka dan operasi.
- Timer dikontrol dengan `timer1.Enabled` untuk mengatur batas waktu permainan.
- `return;` digunakan dalam `GenerateQuestion()` untuk mencegah pembuatan soal baru saat waktu habis.
- Masih terdapat beberapa kesalahan di kode programnya.

## Kontributor
- Developer: [Dimas Satyo Wijayanto]
