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
	$username = $_POST["usernamePost"]; //"Lucas Test AC";
	$email = $_POST["emailPost"];//"test email";
	$password = $_POST["passwordPost"];//"123456";
	
	$sql = "INSERT INTO userinfo (Name, Email, Password)
			VALUES ('".$username."','".$email."','".$password."')";
	$result = mysqli_query($conn ,$sql);
	
	if(!result) echo "there was an error";
	else echo "Everything ok.";

?>