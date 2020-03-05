import React from 'react';

function Dashboard() {
  return (
    <div className="container-fluid mt-4">
      <div className="container">
        <h4 className="mb-4">Dashboard</h4>
        <div className="row">
          <div className="col-sm-3">
            <div className="card border border-primary shadow-sm">
              <div className="card-header">New</div>
              <div className="card-body">
                <h5 className="card-title">10 in the queue</h5>
                <button className="btn btn-primary">Show me</button>
              </div>
            </div>
          </div>
          <div className="col-sm-3">
            <div className="card border border-warning">
              <div className="card-header">In-progress</div>
              <div className="card-body">
                <h5 className="card-title">5 in-progress</h5>
                <button className="btn btn-warning">Show me</button>
              </div>
            </div>
          </div>
          <div className="col-sm-3">
            <div className="card border border-success">
              <div className="card-header">Completed</div>
              <div className="card-body">
                <h5 className="card-title">20 completed</h5>
                <button className="btn btn-success">Show me</button>
              </div>
            </div>
          </div>
          <div className="col-sm-3">
            <div className="card border border-danger">
              <div className="card-header">Cancelled</div>
              <div className="card-body">
                <h5 className="card-title">3 cancelled</h5>
                <button className="btn btn-danger">Show me</button>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}

export default Dashboard;
