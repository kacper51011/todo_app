import { HeroSection } from "../components/HeroSection";
import { IconsSection } from "../components/IconsSection";
import { LandingNavbar } from "../components/LandingNavbar";
import { LastSection } from "../components/LastSection";

export const Landing = () => {
  return (
    <div className="w-full flex flex-col items-center">
      <LandingNavbar />
      <HeroSection />
      <IconsSection />
      <LastSection />
    </div>
  );
};
