import { ReactNode } from "react";
import { IconBase } from "react-icons";

type props = {
  icon: ReactNode;
  description: string;
};

export const IconWithText = ({ icon, description }: props) => {
  return (
    <div className="flex flex-col items-center mx-10">
      <IconBase className="text-[50px] mb-5 text-main">{icon}</IconBase>
      <span className="text-lg">{description}</span>
    </div>
  );
};
