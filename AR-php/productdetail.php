<?php
$servername = "localhost";
$username="root";
$password="";
$dbName="ar";

$conn = new mysqli($servername,$username,$password,$dbName);

$connect = "SELECT ID,Product,material,color,price,Image From product_details";
$ans = mysqli_query($conn ,$connect);

if(mysqli_num_rows($ans)>0){
		while ($row = mysqli_fetch_assoc($ans)){
			echo "id:".$row['ID']."|material:".$row['Product']."<br>"."|cost:".$row['Image']."<br>"."<br>";
		}

 }

?>