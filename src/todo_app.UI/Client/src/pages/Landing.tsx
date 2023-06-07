import { HeroSection } from "../components/HeroSection";
import { IconsSection } from "../components/IconsSection";
import { LandingNavbar } from "../components/LandingNavbar";

export const Landing = () => {
  return (
    <div className="w-full flex flex-col items-center">
      <LandingNavbar />
      <HeroSection />
      <IconsSection />
    </div>
  );
};
