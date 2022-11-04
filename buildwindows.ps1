certutil -user -p jukatest -importPFX Juka.pfx
$mypwd = ConvertTo-SecureString -String "jukatest" -Force -AsPlainText
$Thumbprint = (Get-PfxData -Password $mypwd -FilePath "./Juka.pfx").EndEntityCertificates.Thumbprint
dotnet publish -f net6.0-windows10.0.19041.0 -c Debug /p:PackageCertificateThumbprint="$Thumbprint" /p:PackageCertificateKeyFile="Juka.cer" /p:AppxPackageSigningEnabled=true