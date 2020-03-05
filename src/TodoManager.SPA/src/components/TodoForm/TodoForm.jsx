import React from 'react';

function TodoForm() {
  return (
    <div className="container-fluid mt-4">
      <div className="container mb-4">
        <h4 className="mb-4">Create/Update Todo</h4>
        <div className="border shadow-sm p-4">
          <p>Use this form to create a new todo item</p>

          <form>
            <div className="form-group">
              <label for="title">Title</label>
              <input type="text" className="form-control" id="title" />
            </div>
            <div className="form-group">
              <label for="description">Description</label>
              <textarea
                className="form-control"
                name="description"
                id="description"
                rows="6"
              ></textarea>
            </div>
            <div className="form-group">
              <label for="start">Start Date</label>
              <input
                type="text"
                className="form-control"
                id="start"
                name="start"
              />
            </div>
            <div className="form-group">
              <label for="start">Due Date</label>
              <input type="text" className="form-control" id="due" name="due" />
            </div>
            <div className="form-group">
              <label for="status">Status</label>
              <select name="status" id="status" className="form-control">
                <option value="0" selected>
                  New
                </option>
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
