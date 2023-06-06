import { HeroSection } from "../components/HeroSection";
import { LandingNavbar } from "../components/LandingNavbar";

export const Landing = () => {
  return (
    <div className="w-full flex flex-col items-center">
      <LandingNavbar />
      <HeroSection />
    </div>
  );
};
