<?php
	$servername = "localhost";
	$server_username =  "root";
	$server_password = "";
	$dbName = "ar";

	$conn = new mysqli($servername, $server_username, $server_password, $dbName);

	$query = " SELECT * FROM userinfo WHERE Name ='$username'";

	$result = mysqli_query($conn ,$query) or die('Query failed:'.mysqli_error());
?>