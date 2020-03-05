import React from 'react';

function TodoItem(props) {
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
        <div className="badge badge-primary w-75 p-1">{props.status}</div>
      </td>
    </tr>
  );
}

export default TodoItem;
