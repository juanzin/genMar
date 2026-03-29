<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manager.aspx.cs" Inherits="photographyWeb.manager" %>

<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8" />
  <meta name="viewport" content="width=device-width, initial-scale=1.0" />
  <title>Photographer Account Management</title>
   <link rel="stylesheet" href="Styles/managerStyles.css" />
</head>
<body>
  <div class="page">
    <header class="topbar">
      <div class="breadcrumb">Dashboard / Manage Account</div>
      <div class="user-box">
        <span>Juan Pérez</span>
        <div class="avatar">JP</div>
      </div>
    </header>

    <section class="hero">
      <div>
        <h1>Manage Your Account</h1>
        <p>Upload photos, edit your contact details, and keep your portfolio up to date.</p>
      </div>

      <nav class="nav">
        <a href="#" class="active">Dashboard</a>
        <a href="#">Portfolio</a>
        <a href="#">Messages</a>
        <a href="#">Settings</a>
      </nav>
    </section>

    <main class="layout">
      <section class="panel">
        <h2 class="section-title">Gallery Management</h2>

        <div class="upload-row">
          <button class="btn">⬆ Upload Images</button>
        </div>

        <div class="gallery">
          <div class="upload-card">
            <div class="icon">📷</div>
            <div>Add new photo</div>
          </div>

          <div class="photo-card">
            <img src="https://images.unsplash.com/photo-1512813195386-6cf811ad3542?auto=format&fit=crop&w=600&q=80" alt="Photo 1">
            <div class="card-actions">
              <div class="action">✎</div>
              <div class="action">🗑</div>
            </div>
          </div>

          <div class="photo-card">
            <img src="https://images.unsplash.com/photo-1527631746610-bca00a040d60?auto=format&fit=crop&w=600&q=80" alt="Photo 2">
            <div class="card-actions">
              <div class="action">✎</div>
              <div class="action">🗑</div>
            </div>
          </div>

          <div class="photo-card">
            <img src="https://images.unsplash.com/photo-1500530855697-b586d89ba3ee?auto=format&fit=crop&w=600&q=80" alt="Photo 3">
            <div class="card-actions">
              <div class="action">✎</div>
              <div class="action">🗑</div>
            </div>
          </div>

          <div class="photo-card">
            <img src="https://images.unsplash.com/photo-1518546305927-5a555bb7020d?auto=format&fit=crop&w=600&q=80" alt="Photo 4">
            <div class="card-actions">
              <div class="action">✎</div>
              <div class="action">🗑</div>
            </div>
          </div>

          <div class="photo-card">
            <img src="https://images.unsplash.com/photo-1518105779142-d975f22f1b0a?auto=format&fit=crop&w=600&q=80" alt="Photo 5">
            <div class="card-actions">
              <div class="action">✎</div>
              <div class="action">🗑</div>
            </div>
          </div>

          <div class="photo-card">
            <img src="https://images.unsplash.com/photo-1504593811423-6dd665756598?auto=format&fit=crop&w=600&q=80" alt="Photo 6">
            <div class="card-actions">
              <div class="action">✎</div>
              <div class="action">🗑</div>
            </div>
          </div>

          <div class="photo-card">
            <img src="https://images.unsplash.com/photo-1515961892153-49ad34ad9ebf?auto=format&fit=crop&w=600&q=80" alt="Photo 7">
            <div class="card-actions">
              <div class="action">✎</div>
              <div class="action">🗑</div>
            </div>
          </div>

          <div class="photo-card">
            <img src="https://images.unsplash.com/photo-1494790108377-be9c29b29330?auto=format&fit=crop&w=600&q=80" alt="Photo 8">
            <div class="card-actions">
              <div class="action">✎</div>
              <div class="action">🗑</div>
            </div>
          </div>

          <div class="photo-card">
            <img src="https://images.unsplash.com/photo-1507525428034-b723cf961d3e?auto=format&fit=crop&w=600&q=80" alt="Photo 9">
            <div class="card-actions">
              <div class="action">✎</div>
              <div class="action">🗑</div>
            </div>
          </div>

          <div class="photo-card">
            <img src="https://images.unsplash.com/photo-1470770903676-69b98201ea1c?auto=format&fit=crop&w=600&q=80" alt="Photo 10">
            <div class="card-actions">
              <div class="action">✎</div>
              <div class="action">🗑</div>
            </div>
          </div>

          <div class="photo-card">
            <img src="https://images.unsplash.com/photo-1460661419201-fd4cecdf8a8b?auto=format&fit=crop&w=600&q=80" alt="Photo 11">
            <div class="card-actions">
              <div class="action">✎</div>
              <div class="action">🗑</div>
            </div>
          </div>
        </div>

        <div class="pagination">
          <span>‹</span>
          <div class="page-pill active">1</div>
          <div class="page-pill">2</div>
          <span>›</span>
        </div>
      </section>

      <aside class="panel">
        <h2 class="section-title">Contact Information</h2>

        <form class="form">
          <div class="field">
            <label class="label"><span class="emoji">✉</span> Email Address</label>
            <input type="email" placeholder="juan.perez@example.com" />
          </div>

          <div class="field">
            <label class="label"><span class="emoji">☎</span> Phone Number</label>
            <input type="text" placeholder="(123) 456-7890" />
          </div>

          <div class="field">
            <label class="label"><span class="emoji">📍</span> Location</label>
            <input type="text" placeholder="Puebla, Mexico" />
          </div>

          <div class="field">
            <label class="label"><span class="emoji">◎</span> Instagram</label>
            <input type="text" placeholder="@kualtzin_photo" />
          </div>

          <div class="field">
            <label class="label"><span class="emoji">✎</span> Bio</label>
            <textarea rows="5" placeholder="Landscape and cultural photographer based in Mexico."></textarea>
          </div>

          <button type="submit" class="btn save-btn">Update Info</button>
        </form>
      </aside>
    </main>
  </div>
</body>
</html>

