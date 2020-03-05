import React from 'react';

function DashboardCard(props) {
  const style = status => {
    switch (status) {
      case '0':
        return 'primary';
      case '1':
        return 'warning';
      case '2':
        return 'success';
      case '3':
        return 'danger';

      default:
        break;
    }
    return 'btn btn-primary';
  };

  const btnStyle = `btn btn-${style(props.status)}`;
  const cardStyle = `card border border-${style(props.status)} shadow-sm`;

  return (
    <div className="col-sm-3">
      <div className={cardStyle}>
        <div className="card-header">{props.header}</div>
        <div className="card-body">
          <h5 className="card-title">{props.body}</h5>
          <button className={btnStyle}>Show me</button>
        </div>
      </div>
    </div>
  );
}

export default DashboardCard;
