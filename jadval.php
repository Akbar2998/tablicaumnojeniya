 <html>
 <head>
 	<link rel="stylesheet" type="text/css" href="server.css">
 	<title>Karra Jadval by ZaraSOFT</title>
 </head>
 <body>
 <span>Karra Jadval PHP by ZaraSOFT <br>----------------------------------------------------------------------<br></span>
 </body>
 </html>

 <?
$x = 10;
$y = 10;
$tr = 1;
echo "<table>";

while ( $tr <= $y) {
	echo "<tr>";
	$td = 1;
	while ($td <= $x) {
		echo "<td>" .$tr*$td. "</td>";
		$td++;
	}
	echo "</tr>";
	$tr++;
}

echo "</table>";
  ?>
