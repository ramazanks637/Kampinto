using System;
using System.Collections.Generic;
using System.Text;

//Interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız. Bu noktada bu yaptığımız hesaplama, kredilerin
//hepsinde ortaktır ama kodları farklıdır.(Kredi türüne göre faiz oranları dosya masrafları vs. değişir.)

namespace OOP3
{
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
    }
}
