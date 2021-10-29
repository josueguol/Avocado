import logo from './logo.svg';
import './App.css';
import { useFirebaseApp } from 'reactfire';
import Auth from './Auth';

function App() {
  const firebase = useFirebaseApp();
  console.log(firebase);
  return (
    <div className="App">
      <Auth />
    </div>
  );
}

export default App;
