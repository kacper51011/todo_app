export const DaysNamesRow = () => {
  const days = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"];

  return (
    <div className="flex justify-between">
      {days.map((day) => {
        return (
          <p key={day} className="max-md:text-sm text-xl grow text-right text-dayName">
            {day.slice(0, 3)}
          </p>
        );
      })}
    </div>
  );
};
