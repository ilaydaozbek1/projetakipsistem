select *,(select rdmiktar from lazza34095.ReySis.dbo.Recete_Karti_Detay_Tb where  rdskodu='1100100700' and rgelenidid=addurunid ) from lazza34095.ReySis.dbo.Adisyon_detay_adisyonlu where 

addiptalmi=0
and
 adisyonstatu=2
and
 adisyontarihnew>='2024-09-01 04:00'
and adisyontarihnew<='2024-09-27 04:00'
and addsatirtip=2
and (select COUNT(*) from lazza34095.ReySis.dbo.Recete_Karti_Detay_Tb where  rdskodu='1100100700' and rgelenidid=addurunid )>0


select * from lazza34095.ReySis.dbo.Recete_Karti_Detay_Tb where rdskodu='1100100700'

select * from lazza34095.ReySis.dbo.Stok_Karti_Tb where skodu='1100100700'





select bverilenbayikodu, bunvan from reysis.dbo.Bayi_Tb where bstatu=2 and bunvan like '%vene%'