#start=emu8086Example.exe#  ;KLIMA PROGRAMINI KODLA BIRLIKTE CALISTIRIR

#make_bin# ;DOSYANIN CIKTI TURUNU BELIRLER

name "klima"   ;PROJENIN ADI
 
mov bh,30d  ;SICAKLIK BU DERECEDEN BUYUKSE KLIMA ACILIR
mov bl,33d  ;BELIRLENEN SICAKLIK DERECESI

cmp bl,bh   ;BL VE BH DEGERI KARSILASTIRILIR
ja acik     ;BL>BH ISE ACIK FONSIYONUNA SICRAR
 
jmp kapali  ;BL=<BH ISE KAPALI FONKSIYONUNA SICRAR
 
 
 
acik: 
mov al,1      ;AL KAYDEDICISINE 1 DEGERINI ATAR
out 100,al    ;100 PORTUNA AL DEKI DEGERI ATAR
jmp cikis     ;CIKIS KONUMUNA SICRAR

kapali:
mov al,0      ;AL KAYDEDICISINE 0 DEGERINI ATAR 
out 100,al    ;100 PORTUNA AL DEKI DEGERI ATAR

cikis: 

in al,100


hlt   ;KESME GELDIKTEN SONRA DURMAK ICIN KULLANILIR


