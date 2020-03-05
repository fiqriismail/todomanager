import React from 'react';

import Navigation from './shared/Navigation/Navigation';
import Dashboard from './components/Dashboard/Dashboard';
import TodoList from './components/TodoList/TodoList';
import TodoForm from './components/TodoForm/TodoForm';

function App() {
  return (
    <div>
      <Navigation />
      <Dashboard />
      <TodoList />
      <TodoForm />
    </div>
  );
}

export default App;
