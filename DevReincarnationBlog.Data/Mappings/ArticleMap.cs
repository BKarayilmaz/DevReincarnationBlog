using DevReincarnationBlog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevReincarnationBlog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id=Guid.NewGuid(),
                Title= "Yapay Zekanın Geleceği: İnsanlık İçin Aydınlık Bir Yolculuk",  
                Content= "Yapay Zeka (YZ) teknolojisi, son yıllarda hızla gelişerek hayatımızın birçok alanında kendine yer edinmiştir. Ancak, YZ'nin geleceği konusunda daha heyecan verici yenilikler beklemekteyiz. Gelecekteki potansiyeli nedeniyle YZ, insanlığın önünde inanılmaz fırsatlar sunacak ve dünyayı baştan aşağı değiştirecektir.\r\n\r\nİlk olarak, YZ'nin sağlık alanında devrim yaratacağına şüphe yok. YZ destekli tanı sistemleri, tıbbi verilerin analizi ve hastalıkların erken teşhisi gibi alanlarda önemli bir rol oynayacaktır. Bu, hastaların daha iyi tedavi edilmesini ve hastalıkların önlenmesini sağlayarak sağlık hizmetlerini iyileştirecektir. YZ, karmaşık cerrahi işlemlerde de cerrahların yanında yer alacak ve bu alanda daha güvenli ve etkili müdahalelerin gerçekleştirilmesine yardımcı olacaktır.\r\n\r\nYZ'nin başka bir alanı ise ulaşım olacaktır. Otonom araçlar, trafik akışını optimize ederek trafik kazalarını ve gecikmeleri azaltacak. Ayrıca, YZ destekli lojistik sistemleri, mal taşımacılığında daha etkin ve verimli bir şekilde çalışacak ve tedarik zincirinin iyileştirilmesine katkı sağlayacaktır.\r\n\r\nEğitim sektöründe de YZ, büyük bir devrim yapacak. Öğrencilere özel eğitim programları sunarak bireyselleştirilmiş öğrenme deneyimleri sunacak ve eğitimde eşitsizlikleri azaltacak. Ayrıca, öğretmenlerin iş yükünü hafifletecek ve onlara daha fazla öğrenciye odaklanma imkanı verecektir. YZ destekli sanal gerçeklik ve artırılmış gerçeklik uygulamalarıyla da öğrenme deneyimleri daha etkileyici hale gelecektir.\r\n\r\nSon olarak, YZ'nin iş dünyasına etkisi de dikkate değerdir. YZ destekli otomasyon sistemleri, üretim süreçlerini optimize edecek ve verimliliği artıracaktır. Ayrıca, YZ'nin doğal dil işleme ve müşteri hizmetleri alanındaki ilerlemeleri, müşteri deneyimini daha kişiselleştirilmiş hale getirecektir.",
                ViewCount=15,
                CreatedBy="Admin Test",
                CreatedDate= DateTime.Now,                
                CategoryId= Guid.Parse("00B6575F-5640-4080-9DD3-7FE43B04F1E1"),
                ImageId= Guid.Parse("B8A7BB31-7655-47EB-9D59-72C0BE1C8C06"),
                IsDeleted =false
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Sanal Gerçeklik Gözlükleri: Hayal Dünyasına Kapı Aralanıyor",
                Content = "Sanal Gerçeklik (VR) teknolojisi, günümüzdeki en heyecan verici yeniliklerden biridir. VR gözlükleri, kullanıcıları gerçek dünyadan koparıp sanal bir ortama taşıyarak tamamen yeni bir deneyim sunmaktadır. Bu inanılmaz teknoloji, eğlence sektöründen eğitim ve sağlık gibi birçok alanda çığır açmaktadır. VR gözlüklerinin geleceği ise oldukça parlak ve hayal gücümüzün sınırlarını zorlayacak.\r\n\r\nİlk olarak, eğlence sektöründe VR gözlükleri müthiş bir etki yaratmaktadır. Oyun endüstrisi, VR teknolojisi sayesinde kullanıcıları oyunların içine doğrudan yerleştirebilmekte ve daha önce hiç yaşanmamış deneyimler sunmaktadır. Gerçekçi grafikler, üç boyutlu ses efektleri ve hareket kontrolü gibi özellikler, oyuncuların oyun dünyasında tam anlamıyla kaybolmalarını sağlamaktadır. Ayrıca, VR gözlükleri sinema sektöründe de büyük bir potansiyele sahiptir. Sanal sinema deneyimi, seyircilere filmleri daha etkileyici bir şekilde deneyimleme imkanı sunacak ve izleyiciyi olayların tam merkezine yerleştirecektir.\r\n\r\nEğitim alanında VR gözlükleri, öğrenmeyi daha etkili ve eğlenceli hale getirecektir. Sanal sınıflar, öğrencilerin coğrafyayı keşfetmesine, tarihî olayları yeniden yaşamasına veya karmaşık kavramları görsel olarak anlamasına olanak tanıyacaktır. Bu, öğrencilerin daha derin bir anlayış geliştirmelerini ve daha aktif bir şekilde öğrenmelerini sağlayacaktır.\r\n\r\nSağlık alanında VR, terapi ve rehabilitasyon süreçlerinde büyük bir rol oynamaktadır. Örneğin, sanal gerçeklik tedavisi, korku veya anksiyete gibi psikolojik sorunlarla mücadelede etkili bir yöntemdir. Ayrıca, cerrahi eğitimlerde ve acil durum senaryolarında pratik yapma imkanı sunarak sağlık çalışanlarının becerilerini geliştirmelerine yardımcı olmaktadır.\r\n\r\nVR gözlükleriyle ilgili en heyecan verici şey ise potansiyelidir. Gelecekte, VR gözlüklerinin daha hafif, daha ergonomik ve daha gerçekçi hale gelmesi beklenmektedir. Ayrıca, artırılmış gerçeklik (AR) ve sanal gerçeklik (VR) teknolojilerinin birleştirilmesiyle daha etkileyici ve etkileşimli deneyimlerin ortaya çıkması muhtemeldir.\r\n\r\nSanal Gerçeklik Gözlükleri, gelecekte hayatımızı büyük ölçüde etkileyecek bir teknolojidir. Eğlence, eğitim, sağlık ve daha birçok alanda kullanılmaya devam edecek olan VR gözlükleri, insan deneyimini tamamen dönüştürerek bizi yeni dünyalara taşıyacaktır.",
                ViewCount = 38,
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                CategoryId= Guid.Parse("044B2971-89A5-4596-8DA3-87BCA0C4A7B2"),
                ImageId= Guid.Parse("558C3495-E0BB-4824-BCBF-A48B08263CFE"),
                IsDeleted = false
            });
        }
    }
}
