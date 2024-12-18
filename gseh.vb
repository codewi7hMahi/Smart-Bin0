<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Smart Trash Bin</title>
  <style>
    * {
      margin: 0;
      padding: 0;
      box-sizing: border-box;
    }

    body {
      font-family: Arial, sans-serif;
      height: 100vh;
      display: flex;
      justify-content: center;
      align-items: center;
      background-color: #e0e0e0;
    }

    .container {
      display: flex;
      width: 100%;
      height: 100%;
      position: relative;
    }

    /* Left Side: Image Button */
    .left-side {
      position: absolute;
      top: 0;
      left: 0;
      display: flex;
      flex-direction: column;
      align-items: flex-start;
      justify-content: flex-start;
      padding: 20px;
    }

    .image-button {
      border: none;
      background: transparent;
      margin-bottom: 10px;
      cursor: pointer;
      transition: transform 0.3s;
    }

    .image-button img {
      width: 150px;
      height: 100px;
      border-radius: 8px;
      box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2);
    }

    .image-button:hover {
      transform: scale(1.1);
    }

    /* Right Side: Content */
    .right-side {
      flex: 1;
      display: flex;
      justify-content: flex-end;
      align-items: flex-start;
      padding: 20px;
      background-color: #e4efe6;
    }

    .smart-trash-bin h1 {
      font-size: 3em;
      color: #333;
    }

    .smart-trash-bin p {
      font-size: 1.2em;
      color: #666;
    }
  </style>
</head>
<body>
  <div class="container">
    <!-- Left Side: Image -->
    <div class="left-side">
      <button class="image-button">
        <img src="file:///C:/Users/Mahima/OneDrive/Desktop/ebin/HIW.png" alt="Image">
      </button>
    </div>

    <!-- Right Side: Title -->
    <div class="right-side">
      <div class="smart-trash-bin">
        <h1>Welcome to Smart Bin</h1>
        <p>Your waste management solution</p>
      </div>
    </div>
  </div>
</body>
</html>
