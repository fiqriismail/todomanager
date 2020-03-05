import React, { useState } from 'react';

import TodoItem from './TodoItem';

function TodoList() {
  const [list, setList] = useState([
    {
      id: 1,
      title: 'Todo title 1',
      description: 'The quick brown fox 1',
      start: '06-03-2020',
      due: '08-03-2020',
      status: 0
    },
    {
      id: 2,
      title: 'Todo title 2',
      description: 'The quick brown fox 2',
      start: '06-03-2020',
      due: '08-03-2020',
      status: 1
    }
  ]);

  const todoItems = () => {
    return list.map(item => {
      return (
        <TodoItem
          key={item.id}
          id={item.id}
          title={item.title}
          description={item.description}
          start={item.start}
          due={item.due}
          status={item.status}
        />
      );
    });
  };

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
          <tbody>{todoItems()}</tbody>
        </table>
      </div>
    </div>
  );
}

export default TodoList;
