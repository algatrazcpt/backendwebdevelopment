# Pratik5LinqGroupJoin

Bir okul veritabanı oluşturuyorsunuz ve aşağıdaki iki tablonun verilerini kullanarak group join işlemi gerçekleştirmeniz gerekiyor:

	Öğrenciler Tablosu (Students)

		StudentId: Öğrencinin benzersiz kimliği

		StudentName: Öğrencinin adı

		ClassId: Öğrencinin ait olduğu sınıfın kimliği

		Sınıflar Tablosu (Classes)

		ClassId: Sınıfın benzersiz kimliği

		ClassName: Sınıfın adı

Öğrenciler ve sınıflar arasında group join işlemi yaparak, her sınıfın altında o sınıfa ait olan öğrencilerin listelendiği bir sonuç elde edin. Sonuçları sınıf adıyla birlikte, o sınıfa ait öğrencilerin isimleriyle birlikte ekrana yazdıran bir LINQ sorgusu yazın.