<?php
//Variables for the connection
	$servername = "localhost";
	$server_username =  "root";
	$server_password = "";
	$dbName = "ar";
	
	//Make Connection
	$conn = new mysqli($servername, $server_username, $server_password, $dbName);
	//Check Connection
	if(!$conn){
		die("Connection Failed. ". mysqli_connect_error());
	}

	//Variable from the user	
	$username = $_POST["name"];	
	$password = $_POST["password"];
	$email = $_POST["Email"];
	
	
	
	$sql = "INSERT INTO userinfo (Name, Email, Password)
			VALUES ('".$username."','".$email."','".$password."')";
	$result = mysqli_query($conn ,$sql);
	
	if(!result) echo 0;
	else echo "Everything ok.";

?>