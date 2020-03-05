import React from 'react';

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

  const statusStyle = `badge badge-${style(props.status)} w-75 p-1`;

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
        <div className={statusStyle}>{getStatus(props.status)}</div>
      </td>
    </tr>
  );
}

export default TodoItem;
