import React from 'react';

import StatusToggle from './StatusToggle';

function TodoItem(props) {
  const getStatus = status => {
    const statuses = ['New', 'In Progress', 'Completed', 'Cancelled'];
    return statuses[status];
  };

  const style = status => {
    switch (status) {
      case 0:
        return 'primary';
      case 1:
        return 'warning';
      case 2:
        return 'success';
      case 3:
        return 'danger';

      default:
        break;
    }
    return 'btn btn-primary';
  };

  const toggleButtonStyle = `btn btn-${style(
    props.status
  )} dropdown-toggle btn-sm w-75 `;

  console.log(props.status);

  return (
    <tr>
      <td>{props.id}</td>
      <td>
        <div>
          <strong>{props.title}</strong>
        </div>
        <div>
          <small>{props.description}</small>
        </div>
      </td>
      <td>{props.start}</td>
      <td>{props.due}</td>
      <td>
        <StatusToggle
          statusText={getStatus(props.status)}
          toggleStyle={toggleButtonStyle}
          id={props.id}
        />
      </td>
    </tr>
  );
}

export default TodoItem;
