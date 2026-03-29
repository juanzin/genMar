<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="photographyWeb.main" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Photography Portafolio</title>
    <link rel="stylesheet" href="Styles/mainStyles.css" />
</head>
<body>
    <div class="page-overlay"></div>

    <header class="hero">
        <h1>Juan Onofre</h1>
        <p class="subtitle">Professional Photographer</p>

        <nav class="navbar">
            <a href="#" class="active">Portfolio</a>
            <a href="#">About</a>
            <a href="#">Contact</a>
            <a href="#">Shop</a>
        </nav>
    </header>

    <main class="gallery">
        <div class="card">
            <img src="images/snapshot.png" alt="Snapshots" />
            <div class="card-overlay"></div>
            <div class="card-content">
                <h2>Snapshots</h2>
                <span class="line"></span>
            </div>
        </div>

        <div class="card">
            <img src="images/mexico.png" alt="mexico" />
            <div class="card-overlay"></div>
            <div class="card-content">
                <h2>México</h2>
                <span class="line"></span>
            </div>
        </div>

        <div class="card">
            <img src="images/nature.png" alt="Nature" />
            <div class="card-overlay"></div>
            <div class="card-content">
                <h2>Nature</h2>
                <span class="line"></span>
            </div>
        </div>

        <div class="card">
            <img src="images/unfreezing.png" alt="Unfreezing Time" />
            <div class="card-overlay"></div>
            <div class="card-content">
                <h2>Unfreezing Time</h2>
                <span class="line"></span>
            </div>
        </div>

        <div class="card">
            <img src="images/portrait.png" alt="Portraits" />
            <div class="card-overlay"></div>
            <div class="card-content">
                <h2>Portraits</h2>
                <span class="line"></span>
            </div>
        </div>

        <div class="card">
            <img src="images/animal.png" alt="Animals" />
            <div class="card-overlay"></div>
            <div class="card-content">
                <h2>Animals</h2>
                <span class="line"></span>
            </div>
        </div>
    </main>
</body>
</html>

