$certname = "Juka" 
$cert = New-SelfSignedCertificate -Type Custom `
-Subject "CN=JukaLang" `
-KeyUsage DigitalSignature `
-FriendlyName "Juka Programming Language" `
-CertStoreLocation "Cert:\CurrentUser\My" `
-KeyAlgorithm RSA `
-KeyLength 2048 `
-TextExtension @("2.5.29.37={text}1.3.6.1.5.5.7.3.3", "2.5.29.19={text}")

Export-Certificate -Cert $cert -FilePath ".\$certname.cer"   ## Specify your preferred location
$mypwd = ConvertTo-SecureString -String "jukatest" -Force -AsPlainText
Export-PfxCertificate -Cert $cert -FilePath ".\$certname.pfx" -Password $mypwd