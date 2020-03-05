import React from 'react';

import TodoItem from './TodoItem';

function TodoList() {
  return (
    <div className="container-fluid mt-4">
      <div className="container">
        <h4 className="mb-4">Todo List</h4>
        <table className="table shadow-sm border">
          <thead>
            <tr>
              <th>#</th>
              <th>Details</th>
              <th>Start Date</th>
              <th>Due Date</th>
              <th>Status</th>
            </tr>
          </thead>
          <tbody>
            <TodoItem
              id="1"
              title="Title of the item"
              description="The quick brown fox jumped over the lazy dog"
              start="06-03-2020"
              due="06-03-2020"
              status="Cancelled"
            />
            <TodoItem
              id="2"
              title="Title of the item"
              description="The quick brown fox jumped over the lazy dog"
              start="06-03-2020"
              due="06-03-2020"
              status="In Progress"
            />
          </tbody>
        </table>
      </div>
    </div>
  );
}

export default TodoList;
