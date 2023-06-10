import "./App.css";
import { Calendar } from "./features/calendar/Calendar";

function App() {
  return (
    <div className="w-full min-h-screen overflow-hidden max-md:py:2 max-md:px-3 max-md:py-3 py-12 px-10">
      <Calendar />
    </div>
  );
}

export default App;
