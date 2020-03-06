import React from 'react';

function StatusToggle(props) {
  return (
    <div className="dropdown">
      <button
        className={props.toggleStyle}
        type="button"
        id={`dropdownMenu-${props.id}`}
        data-toggle="dropdown"
        aria-haspopup="true"
        aria-expanded="false"
      >
        {props.statusText}
      </button>
      <div
        className="dropdown-menu"
        aria-labelledby={`dropdownMenu-${props.id}`}
      >
        <button className="dropdown-item" type="button">
          New
        </button>
        <button className="dropdown-item" type="button">
          In Progress
        </button>
        <button className="dropdown-item" type="button">
          Complete
        </button>
        <button className="dropdown-item" type="button">
          Cancel
        </button>
      </div>
    </div>
  );
}

export default StatusToggle;
