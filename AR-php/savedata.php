<?php

$servername="192.168.1.4";
$username="root";
$password="";
$dbName="ar";

$conn = new mysqli($servername,$username,$password,$dbName);

$username = $_POST["name"];



$sql="SELECT * FROM userinfo WHERE Name ='".$username."'";

$result = mysqli_query($conn ,$sql);

if(mysqli_num_rows($result)>0){
	 while($row= mysqli_fetch_assoc($result)){
	 	
	 		
	 		echo "id:".$row['Name']."|material:"."<br>"."|cost:".$row['Email']."<br>"."<br>";
	 	}
	}




//  if (!$conn){
//  	die("Connection Failed.".mysqli_connect_error());
//  }
//  $sql = "SELECT id,Name,Password,Email From userinfo";
//  $result = mysqli_query($conn ,$sql);





// if(mysqli_num_rows($result)>0){
// 		while ($row = mysqli_fetch_assoc($result)){
// 			echo "id:".$row['Name']."|material:".$row['Password']."<br>"."|cost:".$row['Email']."<br>"."<br>";
// 		}

//  }
// $connect = "SELECT ID,Product,material,color,price,Image From product_details";
//  $ans = mysqli_query($conn ,$connect);

// if(mysqli_num_rows($ans)>0){
// 		while ($row = mysqli_fetch_assoc($ans)){
// 			echo "id:".$row['ID']."<br>"."|material:".$row['Product']."<br>".nl2br("|cost:".$row['Image'])."<br>"."<br>";
// 		}

//  }



  
?>