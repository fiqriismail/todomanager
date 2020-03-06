import React from 'react';

import DashboardCard from './DashboardCard';

function Dashboard() {
  return (
    <div className="container-fluid mt-4">
      <div className="container">
        <h4 className="mb-4">Dashboard</h4>
        <div className="row">
          <DashboardCard header="New" body="10 in the queue" status="0" />
          <DashboardCard
            header="In Progress"
            body="5 todos in-progress"
            status="1"
          />
          <DashboardCard header="Completed" body="12 completed" status="2" />
          <DashboardCard
            header="Cancelled"
            body="2 todos cancelled"
            status="3"
          />
        </div>
      </div>
    </div>
  );
}

export default Dashboard;
