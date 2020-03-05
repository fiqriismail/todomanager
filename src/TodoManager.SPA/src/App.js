import React from 'react';
import { BrowserRouter, Switch, Route } from 'react-router-dom';

import Navigation from './shared/Navigation/Navigation';
import Dashboard from './components/Dashboard/Dashboard';
import TodoList from './components/TodoList/TodoList';
import TodoForm from './components/TodoForm/TodoForm';

function App() {
  return (
    <div>
      <BrowserRouter>
        <Navigation />
        <Switch>
          <Route path="/new">
            <TodoForm />
          </Route>
          <Route path="/todos">
            <TodoList />
          </Route>
          <Route path="/">
            <Dashboard />
          </Route>
        </Switch>
      </BrowserRouter>
    </div>
  );
}

export default App;
