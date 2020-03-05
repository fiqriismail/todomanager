import React from 'react';

import { Link } from 'react-router-dom';

function Navigation() {
  return (
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
      <span class="navbar-brand mb-0 h1">Todo Manager</span>
      <button
        class="navbar-toggler"
        type="button"
        data-toggle="collapse"
        data-target="#navbarNav"
        aria-controls="navbarNav"
        aria-expanded="false"
        aria-label="Toggle navigation"
      >
        <span class="navbar-toggler-icon"></span>
      </button>
      <div class="collapse navbar-collapse" id="navbarNav">
        <ul class="navbar-nav">
          <li class="nav-item">
            <Link className="nav-link" to="/">
              Dashboard
            </Link>
          </li>
          <li class="nav-item">
            <Link className="nav-link" to="/new">
              Create Todo
            </Link>
          </li>
          <li class="nav-item">
            <Link className="nav-link" to="/todos">
              To do List
            </Link>
          </li>
        </ul>
      </div>
    </nav>
  );
}

export default Navigation;
