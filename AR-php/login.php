<?php
	$servername = "localhost";
	$server_username =  "root";
	$server_password = "";
	$dbName = "ar";


$username = $_POST["name"]; //"Lucas Test AC";
$password = $_POST["password"];

$conn = new mysqli($servername, $server_username, $server_password, $dbName);

$query = " SELECT * FROM userinfo WHERE Name ='$username'";

$result = mysqli_query($conn ,$query) or die('Query failed:'.mysqli_error());

if(!$result){
	echo 1;
}
else
{
	if(mysqli_num_rows($result)>0){
		$check=0;
		 while($row = mysqli_fetch_assoc($result)){
			 	if ($row['Password']==$password){
			 		$check=1;
			 		echo "id:".$row['id'].",name:".$row['Name'];
			 	}
		}
		if($check==0)
		{
			echo 1;
		}
	}
	else{
		echo 1;
	}
}
?>