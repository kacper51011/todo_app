import { Routes, Route } from "react-router";
import { Landing } from "../pages/Landing";

export const AppRoutes = () => {
  return (
    <Routes>
      <Route path="/" element={<Landing />} />
    </Routes>
  );
};
