import logo from './bowlingpic.png';
import 'bootstrap/dist/css/bootstrap.min.css';

function Header() {
  return (
    <header className="row header navbar navbar-dark bg-dark">
      <div className="col-4">
        <img src={logo} className="logo" alt="logo" />
      </div>
      <div className="col subtitle">
        <h1 className="text-white">Welcome to Bowler's League!</h1>
      </div>
    </header>
  );
}

export default Header;
