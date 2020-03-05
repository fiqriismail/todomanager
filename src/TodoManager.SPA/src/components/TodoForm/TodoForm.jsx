import React, { useState } from 'react';

function TodoForm() {
  const [todo, setTodo] = useState({
    id: '',
    title: '',
    description: '',
    start: '',
    due: '',
    status: 0
  });

  const handleOnChange = e => {
    e.persist();
    setTodo(todo => ({ ...todo, [e.target.name]: e.target.value }));
  };

  const submitForm = e => {
    e.preventDefault();
    console.log(todo);
  };

  return (
    <div className="container-fluid mt-4">
      <div className="container mb-4">
        <h4 className="mb-4">Create/Update Todo</h4>
        <div className="border shadow-sm p-4">
          <p>Use this form to create a new todo item</p>

          <form onSubmit={submitForm}>
            <div className="form-group">
              <label htmlFor="title">Title</label>
              <input
                type="text"
                className="form-control"
                id="title"
                name="title"
                value={todo.title}
                onChange={handleOnChange}
              />
            </div>
            <div className="form-group">
              <label htmlFor="description">Description</label>
              <textarea
                className="form-control"
                name="description"
                id="description"
                rows="6"
                value={todo.description}
                onChange={handleOnChange}
              ></textarea>
            </div>
            <div className="form-group">
              <label htmlFor="start">Start Date</label>
              <input
                type="text"
                className="form-control"
                id="start"
                name="start"
                value={todo.start}
                onChange={handleOnChange}
              />
            </div>
            <div className="form-group">
              <label htmlFor="start">Due Date</label>
              <input
                type="text"
                className="form-control"
                id="due"
                name="due"
                value={todo.due}
                onChange={handleOnChange}
              />
            </div>
            <div className="form-group">
              <label htmlFor="status">Status</label>
              <select
                name="status"
                id="status"
                className="form-control"
                value={todo.status}
                onChange={handleOnChange}
              >
                <option value="0">New</option>
                <option value="1">In-Progress</option>
                <option value="2">Completed</option>
                <option value="3">Canceled</option>
              </select>
            </div>
            <button type="submit" className="btn btn-primary">
              Submit
            </button>
          </form>
        </div>
      </div>
    </div>
  );
}

export default TodoForm;
