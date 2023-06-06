import { ComponentProps } from "react";

type props = {
  isError: boolean;
  errorMessage?: string;
} & ComponentProps<"div">;

export const CustomError = ({ isError, errorMessage, ...props }: props) => {
  return (
    <div {...props} className={`flex flex-col w-full h-10 ${!isError && "hidden"}`}>
      <span role="status" className="font-bold text-error">
        Error occured!
      </span>
      <span className="text-error font-medium">{errorMessage}</span>
    </div>
  );
};
